# VSDCIntegration



//these are the commands for importing the database into instanceo of mysql in docker

- create a folder for the backup in docker
sudo docker exec -it sql mkdir /var/opt/mssql/backup

- copy the file from the local machine into docker
sudo docker cp CHC_Chem_Sandboxbak.bak sql:/var/opt/mssql/backup
sudo docker cp eve-back.bak sql:/var/opt/mssql/backup

- this is the location of the file in docker
/var/opt/mssql/backup/CHC_Chem_Sandboxbak.bak

- delete the back up file
sudo docker rm /var/opt/mssql/backup/CHC_Chem_Sandboxbak.bak
sudo docker rm /var/opt/mssql/backup/eve-back.bak

// this is the command that I used to run the migration and add models backwards into the DataLayer
dotnet ef dbcontext scaffold "Server=localhost; Database=EVO-CHEM; User Id=sa; Password=Hackproof123; Trust Server Certificate=true;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context AppDBContext --no-build --data-annotations --force


// this is the command that I used to run the migration and add models backwards into the DataLayer
dotnet ef dbcontext scaffold "Server=localhost; Database=CHC_CHEM; User Id=sa; Password=Hackproof123; Trust Server Certificate=true;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models2 --context ChcDBContext --no-build --data-annotations --force

