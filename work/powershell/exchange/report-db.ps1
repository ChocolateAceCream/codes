function Get-DatabaseStatistics {
    $Databases = Get-MailboxDatabase -Status
    foreach($Database in $Databases) {
        $DBSize = $Database.DatabaseSize
        $MBCount = @(Get-MailboxStatistics -Database $Database.Name).Count

        $MBAvg = Get-MailboxStatistics -Database $Database.Name |
          %{$_.TotalItemSize.value.ToMb()} |
            Measure-Object -Average            

        New-Object PSObject -Property @{
            Server = $Database.Server.Name
            DatabaseName = $Database.Name
            LastFullBackup = $Database.LastFullBackup
            MailboxCount = $MBCount          
            "AverageMailboxSize (MB)" = $MBAvg.Average
	    "DatabaseSize (GB)" = $MBAvg.Average * $MBCount /1024
        }
    }
}

Get-DatabaseStatistics | Export-Csv ./report.csv -Force -NoType


Get-ADComputer -Filter * -Properties ipv4Address | Format-List name, ipv4* | Export-Csv ./report.csv