Registry check for installed programs

Open powershell as admin and type in the following command:

Get-WmiObject -Class Win32_Product | Export-Csv C:\InstalledSoftware.csv

Then the report can be found at C:\InstalledSoftware.csv