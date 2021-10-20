Database creation:

Add-Migration "Migration Name"
Update-Database



Paths may need to be changed due to different ports in:
API Backend: 	Startup.cs  -ports might be different; in my case API runs on http://localhost:30857
	     	appsettings.json	-database path might be differrent; in my case I use SQL server express

Angular Frontend: device-detail-service.ts	-baseURL could be different due to ports; in my case API runs on http://localhost:30857



Run `ng serve` for a dev server. Navigate to http://localhost:4200/