
 
# Import Active Directory Module 
Import-Module -Name ActiveDirectory 
 
# variables 
$day = Read-Host -Prompt 'Input the number of days you want to tract from today'
$date = (get-Date).tostring() 
$week = (Get-Date).AddDays(-$day) 
 
# Active Directory Task Starts  
 
    write-Host "Getting Computer has not logged on within $day days" 
        $ADuserInWeek = Get-ADComputer -Filter * -Properties * | where { $_.LastLogonDate -le $week } | select Name,LastLogonDate  
        
 
# Create a Excel Workspace 
        $excel = New-Object -ComObject Excel.Application 
 
# make excel visible 
        $excel.visible = $true 
 
# add a new blank worksheet 
        $workbook = $excel.Workbooks.add() 
 
# Adding Sheets 
        $s1 = $workbook.sheets | where {$_.name -eq 'Sheet1'} 
        $s1.Delete() 
 
 
 
# Sheet 2 
# Find All Users those are created with in XXX days
        $s2 = $workbook.sheets | where {$_.name -eq 'Sheet2'} 
        $s2.name = "Result" 
 
#  Add information ot sheet 2 
        $cells= $s2.Cells 
        $s2.range("C1:C1").font.bold = "true" 
        $s2.range("C1:C1").font.size=18 
        $s2.range("C1:C1").cells="List of computer has not logged on within $day days" 
        $s2.range("A3:A3").cells="Name" 
        $s2.range("A3:A3").font.bold = "true" 
        $s2.range("B3:B3").cells="Last log-on date" 
        $s2.range("B3:B3").font.bold = "true" 
 
        $row=3 
        $col1=1 
        $col2=2 
        Foreach ($user in $ADuserInWeek ) { 
        $row++ 
        $col1=1 
        $col2=2 
        $cells.item($Row,$col1)=$user.Name 
        $col1++ 
        $cells.item($Row,$col2)=$user.LastLogonDate 
        $col2++ 
 
        } 
        $s2.range("A3:b3").EntireColumn.autofit() | out-Null 
 
"`n" 
write-Host "Saving file in $env:userprofile\desktop" 
$workbook.SaveAs("./ActiveDirectoryReport.xlsx") 
 