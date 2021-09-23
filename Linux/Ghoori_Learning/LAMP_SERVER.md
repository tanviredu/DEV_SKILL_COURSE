# LAMP Server

-------

1) Check The IP ADDRESS      `ifconfig`

2) Check If it is online           `ping 8.8.8.8`

3) If not connected then configure ip address with `nmtui` Command

4) Update the repository `sudo yum update`

5) install httpd Which is the Apache2 Web Server `yum install httpd`

6) start the process `systemctl start httpd`

7) set as a daemon `systemctl enable httpd`

8) See the status `systemctl status httpd`

9) adding the service in the firewall

   1)  ``firewall-cmd --add-service=http --permanent``
   2) ``firewall-cmd --reload`

   

10) Go to browser and type the ip address or type `localhost`

11) Apache Finished

12) Install Mariadb (both client and server have to be installed)

    1) `yum install mariadb-server mariadb -y`

13) Start the Process

    1) `systemctl start mariadb`
    2) `systemctl enable mariadb`

14.Secure the mariadb

​		`mysql_secure_insallation`

​		Give the password to secure The Mariadb database

15. Maria Db finished

16. Install php and php-mysql

17. `yum install php php-mysql -y`

18. `cd /var/www/html`

19. create a php file `touch index.php`

20. inside the index.php file

    `<?php phpinfo();  ?>`

21.Configure the httpd

22. go to the configuration folder

`cd /etc/httpd/conf`

23.Before editing create a backup

`cp httpd.conf httpd.conf.bak`

24. modify

25. `vim httpd.conf`

26. edit this portion

27. ```
    <IfModule dir_module>
    	Directoryindex index.html index.php index.py index.js
    </IfModule>
    ```

    

28. we add the file name that apache will load
29. Restart the httpd
30. `systemctl restart httpd`











