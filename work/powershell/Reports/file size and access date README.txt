Recursive folder size check with dates last accessed for a given directory

Example usage:
1. Open powershell as admin
2. Type in the following script
get-childitem C:\Temp -Recurse | where {!$_.PSIsContainer} | select-object FullName, LastWriteTime, Length | export-csv -notypeinformation -path C:\files.csv | % {$_.Replace('"','')}

The above script will recursivly check all files under C:\Temp directory and export result to C:\files.csv
