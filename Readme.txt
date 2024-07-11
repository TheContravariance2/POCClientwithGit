
Case Study 1

To install SQL Image
docker pull mcr.microsoft.com/mssql/server:2022-latest

To Run Docker
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Chandan@123" -p 1433:1433 --name chandansqlcontainer --hostname chandansqlcontainer -d mcr.microsoft.com/mssql/server:2022-latest

To Query in Linux Shell
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "yourpassword"


Case Study 2
--------------------------
1. Need to create image of given application(POC Client).
 - docker build -t imagename .                                    (image name should be smallcase and . refer current directory)
Completed

2. We have to create docker-compose file [.yml]
 - We will do entry of all the services  along with SQL server entry.


3. Now we need to apply association between service and database.

4. Strong practice on docker-compose tool. [build, up, down]

5. Now we have to open the connection string of given application to associate with 
corresponding SQL server


Important Remarks:
When we have docker-compose file:
a) Define all the services entries with DB.
b) We don't need to create explicitly image of given service.[POCClient]
c) docker build	-t imagename . [we don't need to run this command]
d) docker-compose build [It will starts creating images for the given YAML file.]
e) docker-compose up [it will create container for the mentioned images on YAML file]


Docker Compose Link

https://learn.microsoft.com/en-us/dotnet/architecture/microservices/multi-container-microservice-net-applications/multi-container-applications-docker-compose


How to view images:
docker images


Adding few changes