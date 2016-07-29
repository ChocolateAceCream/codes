# Jason Hamilton
# https://www.404TechSupport.com/
# Ping a number of computers and report the successful ones.

# List computer name (not FQDN) in ping.txt in the same directory as this script
$ScriptPath = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
Write-Host $ScriptPath
$PCs = Get-Content $ScriptPathping.txt
$timestamp = get-date -f "MMddyyyyHHmm"
$successlog = [string]::concat($Env:userprofile, "Desktoppingable_", $timestamp,".txt")
$faillog = [string]::concat($Env:userprofile, "Desktopnotpingable_", $timestamp,".txt")
Clear-host
Write-Host "Testing connection to computers listed in ping.txt"
Write-Host ""

# loop through above array of each computer and test pinging to them.
Foreach ($i in $PCs)
{
$PC = $i+".domain.fqdn"

$pingable = test-connection -ComputerName $PC -Count 2 -quiet

if ($pingable) {
$pingable2 = test-connection -ComputerName $PC -Count 1

#List successful connections
Write-Host $PC "is pingable with" $pingable2.IPV4Address
$report = [string]::concat($PC, " is pingable with ", $pingable2.IPV4Address)
$report | Out-File -FilePath $successlog -Append

} else {
Write-Host $PC "was not pingable."
$report = [string]::concat($PC, " was not pingable.")
$report | Out-File -FilePath $faillog -Append
}
}

Write-Host ""
#Equivalent to Pause
Read-Host 'Press Enter to continue...' | Out-Null