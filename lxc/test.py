
# Python script to test the automation of LXC container setup
# By Aleksey [github.com/Alekseyyy]

# NOTE: that sometimes the LXC fails to deploy because the base image cannot
#  be downloaded to the system because of some kind of GPG keyserver bug.
#  See the following article to download base images manually:
#  https://askubuntu.com/questions/1035504/lxc-ubuntu-18-04-unable-to-fetch-gpg-key-from-keyserver-when-trying-to-crea

import lxc
import sys

container = lxc.Container("autotest")
if container.defined:
	print("Container already exists")
	sys.exit(1)
	
if not container.create("download", lxc.LXC_CREATE_QUIET, {
								"dist": "ubuntu",
								"release":"bionic",
								"arch":"amd64" 
							}):
	print("Failed to create the container's rootfs", file=sys.stderr)
	sys.exit(1)

if not container.start():
	print("Failed to start the container", file=sys.stderr)
	sys.exit(1)

container.attach_wait(lxc.attach_run_command, ["apt", "update"])
container.attach_wait(lxc.attach_run_command, ["apt", "install", "nmap"])
