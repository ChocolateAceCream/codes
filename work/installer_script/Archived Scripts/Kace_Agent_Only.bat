echo Please Insert the computer name (e.g. \\ServerName):
set /p Computer=
echo Please Insert your username (e.g. chh\jsmith_da):
set /p Username=
echo Please Insert your Password:
set /p Password=

\\chhws1\Installs\installer_script\psexec.exe %Computer% -h -u "%Username%" -p "%Password%" cmd /c "start /wait msiexec.exe /qn /l*v C:\Windows\TEMP\ampmsi.log /i \\MLVKACE-KMG-01.chhins.com\client\agent_provisioning\windows_platform\ampagent-6.4.180-x86.msi HOST=MLVKACE-KMG-01.chhins.com"l
