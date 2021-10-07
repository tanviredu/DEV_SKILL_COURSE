```bash
=> ifconfig
=> yum update
=> yum install samba samba-client samba-common -y
=> systemctl start smb
=> systemctl start nmb
=> systemctl enable smb
=> systemctl enable nmb
=> firewall-cmd --add-service=samba  --permanent
=> firewall-cmd --reload
=> mkdir /home/share
=> cd /home/share
=> mkdir everyone
=> chmod -R 775 /home/share/everyone
=> chown -R nobody:nobody /home/share/everyone
=> cd /etc/samba/
=> cp smb.config smb.config.bak
=> vim smb.config (add this with existing)
--------------------------------------------------------
[EveryoneAccess]
	comment = Open Samba
	path=/home/share/everyone
	browsable = yes
	writable = yes
	guest ok = yes
	read only = no
	create mode = 0775
	directory mode = 0775
--------------------------------------------------------

=> testparm
=> systemctl restart smb
=> systemctl restart nmb

// from another instance go to file explorer
// then +Other Location
// enter url smb://<your_ip>





```

