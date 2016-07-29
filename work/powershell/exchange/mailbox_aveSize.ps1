function Get-DatabaseStatistics {
    $Databases = Get-MailboxDatabase -Status
    foreach($Database in $Databases) {
        $DBSize = $Database.DatabaseSize
        $MBCount = @(Get-MailboxStatistics -Database $Database.Name).Count
        
        $MBAvg = Get-MailboxStatistics -Database $Database.Name | 
          %{$_.TotalItemSize.value} | 
            Measure-Object -Average            

        New-Object PSObject -Property @{
            Server = $Database.Server.Name
            DatabaseName = $Database.Name
            LastFullBackup = $Database.LastFullBackup
            MailboxCount = $MBCount
            "DatabaseSize (GB)" = $DBSize
            "AverageMailboxSize (MB)" = $MBAvg.Average
            "WhiteSpace (MB)" = $Database.AvailableNewMailboxSpace
        }
    }   
}