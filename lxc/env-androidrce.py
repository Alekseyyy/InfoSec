
# Automated LXC (Linux Containers) setup script
# - Creates an Android software reverse engineering lab [ALPHA RELEASE / UNFINISHED]

# By Aleksey <hackermaneia@riseup.net>
# - GitHub: https://github.com/Alekseyyy

import lxc
import sys
import argparse

parser = argparse.ArgumentParser(description="Use LXC to setup an Android reverse engineering lab")
parser.add_argument("--name", action="store", type=str, default="android-rce", help="the name of the container")
parser.add_argument("--user", action="store", type=str, default="dev", help="the user's ssh username")
args = parser.parse_args()

container = lxc.Container(args.name)

# Does the container already exist?
if container.defined:
	print("Container of the name %s already exists. Exiting..." % args.name)
	sys.exit(1)

# Create and start the container
if not container.create(
	"download",
	lxc.LXC_CREATE_QUIET,
	{
		"dist":"ubuntu",
		"release":"focal",
		"arch":"amd64"}):
		
	print("Failed to create the Android reverse engineering lab.")
	print("NOTE: that if downloading the base image, the script might not be getting it correctly due to some gpg keyserver misconfiguration, so you should download it manually from terminal")
	sys.exit(1)
print("Created the Android reverse engineering lab!")

if not container.start():
	print("Failed to start the Android reverse engineering lab.")
	sys.exit(1)
print("Started the Android reverse engineering lab!")

# Setup the container

print("Setting up the container...")
container.get_ips(timeout=30)

setup_commands = (

	# Housekeeping stuff...
	["apt", "update"],
	["apt", "dist-upgrade"],

	# Install necessary packages...	
	["apt", "install", "python3", "python3-pip"],
	["apt", "install", "default-jre", "default-jdk"],
	["apt", "install", "unzip"],
	["snap", "install", "android-studio", "--classic"],
	
	# Add and su to the regular user...
	["adduser", args.user],
	["apt", "install", "ssh"]
	
	# Install Apktool...
	# Install dex2jar and Java Decompiler...	
)

for command in setup_commands:
	container.attach_wait(lxc.attach_run_command, command)
	
print("\nFinished setting up!")
print("Container state: %s" % container.state)
print("Container PID: %s\n" % container.init_pid)
