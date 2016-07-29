
1. open the powershell as admin 
2. go to the directory where the script stored
3. type in the following command:
./NTFS.ps1 C:\ | Export-Csv C:\PermissionsAudit.csv –NoTypeInformation
4. Wait about 10-15 mins to let the script run, the result will be found from C:\PermissionsAudit.csv

Get-WmiObject -Class Win32_Product | Export-Csv C:\InstalledSoftware.csv

\\chhws1\lockers

get-childitem D:\temp -rec | where {!$_.PSIsContainer} |
select-object FullName, LastWriteTime, Length | export-csv -notypeinformation -delimiter '|' -path file.csv


get-childitem C:\ -Recurse | where {!$_.PSIsContainer} | select-object FullName, LastWriteTime, Length | export-csv -notypeinformation -path C:\files.csv | % {$_.Replace('"','')}