Technologies used: ASP .NET 5.0 , Microsoft SQL Server Express , Angular 11

1. Download repository

2. Open API in visual studio by running DeviceAPI.sln

3. Database creation:

Add-Migration "Migration Name"
Update-Database

4. Build and run API. In my case API runs on http://localhost:30857

5. Open DeviceManager folder in IDE

6. Run npm install

7. Paths may need to be changed due to different ports in:
	API Backend: 	Startup.cs  -ports might be different; in my case API runs on http://localhost:30857
	     		appsettings.json	-database path might be differrent; in my case I use SQL server express

	Angular Frontend: device-detail-service.ts	-baseURL could be different due to ports

8. Run `ng serve` for a dev server. Navigate to http://localhost:4200/