# VSDCAPIApiClient


//Install java and download Tomcat 9

//run these commands from the tomcat folder to get it running
cd /Applications/apache-tomcat-9.0.95/bin

//to start the service
./startup.sh

//to stop the service
./shutdown.sh  


//Run these commands in the terminal

docker pull tomcat:9.0

docker run -d -p 8080:8080 --name my-tomcat-container -v /Users/Nigelo/Source/VSDCAPIApiClient/zrasandboxvsdc/zrasandboxvsdc.war tomcat:9.0


//this command was run to do a migration, it has the initial connection string


dotnet ef dbcontext scaffold "Server=localhost; Database=EVO-CHEM; User Id=sa; Password=Hackproof123; Trust Server Certificate=true;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context AppDBContext --no-build --data-annotations --force
