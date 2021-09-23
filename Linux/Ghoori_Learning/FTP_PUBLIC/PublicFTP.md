# PUBLIC FTP SERVER FOR REDHAT 7

# (NO PASSWORD)

---------



```
Connection Test:
---------------------------------------------
=>ifconfig
ip : 192.168.0.10
=>ping 8.8.8.8
---------------------------------------------

install packages:
---------------------------------------------
=>yum update -y
=>yum install vsftpd -y
=>systemctl start vsftpd
=>systemctl enable vsftpd
=>firewall-cmd --add-service=ftp --permanent
=>firewall-cmd --reload
----------------------------------------------
=>setenforce 0   

configure selinux parmanently:
=>vim /etc/selinux/config
-----------------------
SELINUX=permissive
-----------------------

after changing the SELINUX reboot the server
to reflect the SELINUX change Parmenently

configure FTP for everyone/anonymous
------------------------------------
=>cd /etc/vsftpd
=>cp vsftpd.conf vsftpd.conf.bak
=>vim vsftpd.conf
--------------------------
anonymous_enable=YES
local_enable=NO
write_enabled=NO
----------------------------

we set the write_enabled=NO so that nobody
can change anything to the server 
they can just download. 


=>systemctl restart vsftpd


the folder that is going to expose is
"/var/ftp/pub"

=>cd /var/ftp/pub
=>touch demo.txt

now go to fileZilla to download it

address : ftp://192.168.0.10






```

