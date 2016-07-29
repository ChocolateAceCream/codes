
 
# Import Active Directory Module 
Import-Module -Name ActiveDirectory 
 
# variables 
$day = Read-Host -Prompt 'Input the number of days you want to tract from today'
$date = (get-Date).tostring() 
$week = (Get-Date).AddDays(-$day) 
 
# Active Directory Task Starts  
 
    write-Host "Getting users created within $day days" 
        $ADuserInWeek = Get-ADUser -Filter * -Properties * | where { $_.whenCreated -ge $week } | select Name,whenCreated  
    write-Host "Getting users those password are Never expirpes" 
        $passNeverExpire =  Get-ADUser -Filter * -Properties PasswordNeverExpires | where { $_.PasswordNeverExpires -eq $true } | select Name | sort 
    Write-Host "getting Computer Accounts" 
        $inAcComp = Get-ADComputer -Filter "Enabled -eq '$false'" | Select Name  
    write-Host "getting disable User accounts" 
        $disableUser = Get-ADUser -Filter "Enabled -eq '$false'" | Select Name 
    write-Host "getting inactive User within $day days" 
        $inacUser = Get-ADUser -Filter {LastLogonTimeStamp -lt $week -and enabled -eq $true} -Properties LastLogonTimeStamp | Select Name,@{Name="Stamp"; Expression={[DateTime]::FromFileTime($_.lastLogonTimestamp).ToString('yyyy-MM-dd_hh:mm:ss')}}
         
 
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
        $s2.name = "User Created in week" 
 
#  Add information ot sheet 2 
        $cells= $s2.Cells 
        $s2.range("C1:C1").font.bold = "true" 
        $s2.range("C1:C1").font.size=18 
        $s2.range("C1:C1").cells="List of Active Directory User Account those are created with-in $day days." 
        $s2.range("A3:A3").cells="Name" 
        $s2.range("A3:A3").font.bold = "true" 
        $s2.range("B3:B3").cells="When Created" 
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
        $cells.item($Row,$col2)=$user.whenCreated 
        $col2++ 
 
        } 
        $s2.range("A3:b3").EntireColumn.autofit() | out-Null 
 
#Sheet 3 Users with Password Never Expire Set 
        $s3 = $workbook.sheets | where {$_.name -eq 'Sheet3'} 
        $s3.name = "Pass Never Expire" 
 
#  Add information ot sheet 2 
        $cells= $s3.Cells 
        $s3.range("C1:C1").font.bold = "true" 
        $s3.range("C1:C1").font.size=18 
        $s3.range("C1:C1").cells="List of Active Directory Users those Password are set to never expire.." 
        $s3.range("A3:A3").cells="Name" 
        $s3.range("A3:A3").font.bold = "true" 
 
        $row1=3 
        $col3=1 
        Foreach ( $Passw in $passNeverExpire) { 
        $row1++ 
        $col3=1 
        $cells.item($Row1,$col3)=$Passw.Name 
        $col3++ 
        } 
        $s3.range("A3:A3").EntireColumn.autofit() | out-Null 
 
### Adding Sheet 4  
        $s4 = $workbook.Sheets.add() 
        $s4.name = "Inactive Computers" 
        $cells= $s4.Cells 
        $s4.range("C1:C1").font.bold = "true" 
        $s4.range("C1:C1").font.size=18 
        $s4.range("C1:C1").cells="List of Inactive Computer Acccounts" 
        $s4.range("A3:A3").cells="Name" 
        $s4.range("A3:A3").font.bold = "true" 
         
        $row4=3 
        $col4=1 
        Foreach ( $Com in $inAcComp) { 
        $row4++ 
        $col4=1 
        $cells.item($Row4,$col4)=$Com.Name 
        $col4++ 
        } 
        $s4.range("A3:A3").EntireColumn.autofit() | out-Null 

### Adding Sheet 7 
        $s7 = $workbook.Sheets.add() 
        $s7.name = "Inactive Computers" 
        $cells= $s7.Cells 
        $s7.range("C1:C1").font.bold = "true" 
        $s7.range("C1:C1").font.size=18 
        $s7.range("C1:C1").cells="List of Inactive Computer Acccounts" 
        $s7.range("A3:A3").cells="Name" 
        $s7.range("A3:A3").font.bold = "true" 
         
        $row4=3 
        $col4=1 
        Foreach ( $Com in $inAcComp) { 
        $row4++ 
        $col4=1 
        $cells.item($Row4,$col4)=$Com.Name 
        $col4++ 
        } 
        $s4.range("A3:A3").EntireColumn.autofit() | out-Null 
 
## Sheet 5 
        $s5 = $workbook.Sheets.add() 
        $s5.name = "Disable User Account" 
        $cells= $s5.Cells 
        $s5.range("C1:C1").font.bold = "true" 
        $s5.range("C1:C1").font.size=18 
        $s5.range("C1:C1").cells="List of Disable User Acccounts" 
        $s5.range("A3:A3").cells="Name" 
        $s5.range("A3:A3").font.bold = "true" 
        $row5=3 
        $col5=1 
        Foreach ( $Us in $disableUser) { 
        $row5++ 
        $col5=1 
        $cells.item($Row5,$col5)=$Us.Name 
        $col5++ 
        } 
        $s5.range("A3:A3").EntireColumn.autofit() | out-Null 
         
         
# get sheet and update sheet name 
        $s6 = $workbook.Sheets.add() 
        $s6.name = "Report Information" 
         
# Put user information on Sheet - 1  
        $s6.range("D7:D7").cells="Title:" 
        $s6.range("D7:D7").font.bold = "true" 
        $s6.range("E7:E7").cells="Active Directory Report" 
        $s6.range("D8:D8").font.bold = "true" 
        $s6.range("D8:D8").cells="Generated By:" 
        $s6.range("E8:E8").cells="$env:username" 
        $s6.range("D9:D9").font.bold = "true" 
        $s6.range("D9:D9").cells="Generated Date:" 
        $s6.range("E9:E9").cells=$date 
        $s6.range("D7:D9").EntireColumn.autofit() | out-Null         
#Saving File 
"`n" 
write-Host "Saving file in $env:userprofile\desktop" 
$workbook.SaveAs("./ActiveDirectoryReport.xlsx") 
 