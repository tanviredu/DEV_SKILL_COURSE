# FTP SERVER FOR RESTRICTED USER IN THE SERVER (REDHAT 7)

-------------------------



|                                                              | Command                                                      |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| 1) Check The Ip address                                      | ifconfig                                                     |
| 2) Set the Ip address (if not already set )                  | nmtui                                                        |
| 3) ping the google dns server                                | ping 8.8.8.8                                                 |
| 4) Install the vsftpd package                                | yum install vsftpd -y                                        |
| 5) start and enable the server                               | 1)  systemctl start vsftpd; <br>2) systemctl enable vsftpd   |
| 6) Add the service to the Firewall                           | firewall-cmd --add-service=ftp --permanent                   |
| 7) Reload the firewall                                       | firewall-cmd --reload                                        |
| 8) adding the port to The firewall                           | firewall-cmd --add-port=20-21/tcp --permanent                |
| 9) Reload the firewall                                       | firewall-cmd --reload                                        |
| 10) CONFIGURE SELINUX (VVI)                                  | vim /etc/selinux/config <br>--------------------------------- <br/>SELINUX=permissive<br/>-----------------------------------<br/> |
| 1) create a user Group                                       | groupaddd ftpgroup                                           |
| 2) Create users and add then to the group                    | Syntax : useradd -G <group you want to add> <username> <br>1) useradd -G ftpgroup fitpuser_1; <br>2) useradd -G ftpgroup ftpuser_2<br>3) useradd -G ftpgroup ftpuser_3 |
| 3)set the password for the user                              | 1) passwd ftpuser_1 <br>2) passwd ftpuser_2 <br>3) passwd ftpuser_3 |
| 4) Create a folder what you want to serve                    | 1) mkdir /FTP<br>2) mkdir /FTP/download <br>3) mkdir /FTP/upload |
| **********                                                   | ****                                                         |
| 1) Give the user and group (not other) read,write and execute permission to the upload and download folder | 1) chmod 770 /FTP/download <br>2) chmod 770 /FTP/upload      |
| 2) Change the ownership of the folder to <br>1) user 'root'<br>2) and group 'ftpgroup' <br> So the root user [administrator] and the ftpgroup will be the owner <br>3) syntax is  chown -R <user>:<group> <folder> | chown -R root:ftpgroup /FTP                                  |
| 4) go to the configuration folder                            | cd /etc/vsftpd                                               |
| 5) create backup for configuration file                      | cp vsftpd.cong vsftpd.conf.bak                               |
| 6) create a text file where all user's name will be stored   | touch list_user_ftp                                          |
| 7) edit the text file                                        | vim  list_user_ftp<br>--------------------------------------------- <br>ftpuser_1<br>ftpuser_2<br>ftpuser_3<br>-------------------------------------------<br> |
| 8) edit the configure file <br/>so that anonymous cant login<br/>only user in the text file can login<br/>enable download and upload mechanism<br/>Setting up the folder for ftp server | vim vsftpd.conf <br>--------------------------------------------------<br>anonymous_enable=NO<br/>ascii_upload_enable=YES<br/>ascii_download_enable=YES<br/>chroot_local_user=YES<br/>**comment out the** <br/>=============================<br/>userlist_enable=YES<br/>=============================<br/>userlist_deny=NO<br/>userlist_file=/etc/vsftpd/list_user_ftp<br/>local_root=/FTP<br/>---------------------------------------------------<br> |
| 9) Reload the vsftpd                                         | systemctl restart vsftpd                                     |
| 10) check from the FILEZILLA client                          |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |
|                                                              |                                                              |

```



```

