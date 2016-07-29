$inputFile = "C:\ipaddr.txt"

$OutputFile = "C:\Report.csv"

$servers = Get-Content C:\ipaddr.txt

$collection = $()
$collection += $servers

foreach ($server in $servers)

{

    $status = @{ "ServerName" = $server; "TimeStamp" = (Get-Date -f s) }
    $status["ip"] = $server
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
TABLE {border-width: 1px;border-style: solid;border-color: black;border-collapse: collapse;}
TH {border-width: 1px;padding: 3px;border-style: solid;border-color: black;background-color: #6495ED;}
TD {border-width: 1px;padding: 3px;border-style: solid;border-color: black;}
</style>
"@
 
$collection | Select 'Server Name','TimeStamp', 'Results' | ConvertTo-HTML -Head $Header 
