# all-the-beans 


Required software: node, Visual Studio 2019, .NET core version 2.2

clone project

cd into project

open up powershell in the project's directory

run command 'npm install' to install dependencies

run command: 'npm run build' or 'npm run watch' (development) to bundle the frontend files
   
open up the .sln file in Visual Studio

go to Tools >> NuGet package manager >> package manager console >> run the following commands in the console to seed the database:

- add-migration seed-database -Context BeanContext
- update-database -Context BeanContext

start project with or without debugging after migrations have been complete
