    $inputFile = "C:\ipaddr.txt"

$OutputFile = "C:\Report.csv"

$servers = Get-Content C:\ipaddr.txt

$collection = $()

foreach ($server in $servers)

{

    $status = @{ "ServerName" = $server; "TimeStamp" = (Get-Date -f s) }
    if (Test-Connection $server -Count 1 -ea 0 -Quiet)

    { 

        $status["Results"] = "Up"

    } 

    else 

    { 

        $status["Results"] = "Down" 

    }

    New-Object -TypeName PSObject -Property $status -OutVariable serverStatus

    $collection += $serverStatus

}

$Header = @"
<style>
TABLE {border-width: 1px;border-style: solid;border-color: black;border-collapse: collapse; margin-left: 30px; }
TH {border-width: 1px;padding: 3px;border-style: solid;border-color: black;background-color: #6495ED;}
TD {border-width: 1px;padding: 3px;border-style: solid;border-color: black;}

h1{
clear: both;
font-size: 150%;
margin-left: 20px;
margin-top: 30px;
color:#475F77;
}


</style>
"@

$Pre = "<h1>Heading before the report</h1>"
$Post = "Footer after the report"
 
$collection | Select 'ServerName','TimeStamp', 'Results' | ConvertTo-HTML -Head $Header -PreContent $Pre -PostContent $Post |  Out-File C:\gg.html
