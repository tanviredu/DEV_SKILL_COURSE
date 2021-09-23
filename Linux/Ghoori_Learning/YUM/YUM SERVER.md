# YUM SERVER(FOR REDHAT 7)

```bash
=>mount /dev/cdrom /media
=>mkdir /myrepo
=>cp -r /media/* /myrepo
=>cd /etc/yum.repos.d
=>rm -rf *
=>vim myrepo.repo
------------------------------------------------------------
[myrepo]
baseurl=file:///myrepo
enabled=1
gpgcheck=0
-------------------------------------------------------------
=>yum update
=>yum install <package> -y
```

