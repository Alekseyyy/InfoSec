
# Python script to test the automation of LXC container setup
# By Aleksey [github.com/Alekseyyy]

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
	print("Failed to start the container")
	sys.exit(1)

container.attach_wait(lxc.attach_run_command, ["apt", "update"])
container.attach_wait(lxc.attach_run_command, ["apt", "install", "nmap"])
