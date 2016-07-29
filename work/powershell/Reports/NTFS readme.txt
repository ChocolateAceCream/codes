
1. open powershell as admin
2. go to the directory where NTFS script stored. 
3. type in the following:
./NTFS.ps1 C:\ | Export-Csv C:\PermissionsAudit.csv –NoTypeInformation
4. The above script will audit NTFS for all files under C:\ directory and export result as csv file which will be stored at C:\
