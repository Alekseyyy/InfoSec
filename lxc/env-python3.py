
# Generic Python3 development environment
# - Automated LXC container setup script

# By Aleksey <hackermaneia@riseup.net>
# - GitHub: https://github.com/Alekseyyy

import lxc
import sys
import argparse

parser = argparse.ArgumentParser(description="Use LXC to setup a Python3 development environment")
parser.add_argument("--name", action="store", type=str, default="python3-dev", help="the name of the container")
parser.add_argument("--user", action="store", type=str, default="dev", help="the user's ssh username")
args = parser.parse_args()

container = lxc.Container(args.name)

# Check to see if container already exists
if container.defined:
	print("Container of the name %s already exists. Exiting..." % name)
	sys.exit(1)
	
# Create and start the container
if not container.create("download", lxc.LXC_CREATE_QUIET, {"dist":"ubuntu",
							"release":"bionic",
							"arch":"amd64"}):
	print("Failed to create the Python3 development container. Exiting... ")
	sys.exit(1)
print("Created the Python3 development container!")
if not container.start():
	print("Failed to start the Python3 development container")
	sys.exit(1)
print("Started the Python3 development container!")

# Setup the container
print("Setting up the container...")
container.get_ips(timeout=30) #wait a bit :P

setup_commands = [
	["apt", "update"],
	["apt", "dist-upgrade"],
	
	["apt", "install", "python3"],
	["apt", "install", "python3-pip"],
	["apt", "install",  "ssh"],
	
	["useradd", args.user],
	["mkdir", "/home/%s" % args.user]
]

for k in setup_commands:
	container.attach_wait(lxc.attach_run_command, k)

print("\nFinished setting up! (don't forget to set a password for %s" % args.user)
print("Container state: %s" % container.state)
print("Container PID: %s\n" % container.init_pid)
