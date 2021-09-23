# AGAIN ALL COMMAND IN ONE LAMP SERVER

```
=>ifconfig

=>ping 8.8.8.8
---------------------------------------------

=>yum update
=>yum install httpd -y
=>systemctl start httpd

=>systemctl enable httpd
---------------------------------------------

=>firewall-cmd --add-service=http --permanent

=>firewall-cmd --reload
---------------------------------------------

=>yum install mariadb mariadb-server -y
=>systemctl start mariadb
=>systemctl enable mariadb

=>mysql_secure_insallation
----------------------------------------------

=>yum install php php-mysql -y
----------------------------------------------

=>cd /var/www/html
=>vim index.php
  	<?php phpinfo(); ?>
=>cd /etc/httpd/conf
=>cp httpd.conf httpd.conf.bak
=> vim httpd.conf

	<IfModule dir_module>
		Directoryindex index.html index.php index.py index.js
	</IfModule>
=>systemctl restart httpd
------------------------------------------------

DONE;

```











