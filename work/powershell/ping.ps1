$OutputFile = "C:\Report.csv"


$collection = $()
$userobjects = Import-CSV C:\ipaddr.csv

foreach ($server in $userobjects)

{

    $status = @{ "Name" = $server.name; "ServerName" = $server.ipaddr; "TimeStamp" = (Get-Date -f s) }
    $result = [System.Net.Dns]::GetHostEntry($ComputerIPAddress).HostName
    
    New-Object -TypeName PSObject -Property $status -OutVariable serverStatus

    $collection += $serverStatus

}



$Header = @"
<style>
TABLE {border-width: 1px;border-style: solid;border-color: black;border-collapse: collapse;}
TH {border-width: 1px;padding: 3px;border-style: solid;border-color: black;background-color: #6495ED;}
TD {border-width: 1px;padding: 3px;border-style: solid;border-color: black;}

h1{
clear: both;
font-size: 150%;
margin-top: 30px;
color:#475F77;
}


</style>
"@
$test = Get-Date -UFormat "%Y / %m / %d"
$Pre = "<h1>Daily Report for $test </h1>"
$Post = "Footer after the report"
 
$collection | Select 'Name', 'ServerName','TimeStamp', 'Results' | ConvertTo-HTML -Head $Header -PreContent $Pre -PostContent $Post |  Out-File C:\gg.html
