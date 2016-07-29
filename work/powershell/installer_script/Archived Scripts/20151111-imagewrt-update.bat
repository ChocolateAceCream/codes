
@echo off
REM ---- REM out about line if you want to watch the details -------
CLS


REM ------------------------------------------------------
REM --------------- SET Location of InstallFiles ---------
REM ------------------------------------------------------
REM *****************  UPDATE = UPDATE = UPDATE   ********
REM ***** Update the value for \\SERVER\FOLDER_SHARE *****
SET InstallFiles=\\chhira\ImageWrt\install5\installs
REM **** Normally this is in the imagewrt subfolder containing the other .msi *****
REM **** Example **** SET InstallFiles=\\localserver\imagewrt\install5\installs



REM ------------------------------------------------------
REM --------------- NOTES --------------------------------
REM ------------------------------------------------------

REM *** Make sure the following files are in the SAME location as the batch file ***
REM *** This is the \\SERVER\FOLDER_SHARE location identified above ****************
REM - IRDesktop.msi
REM - IRDocCap.msi
REM - IRDocumentConverter.msi
REM - IRDocumentconvrter.64.msi
REM - IRMicrosoftAddin.msi
REM - IRDesktop.Patch.5.7.18.1548.msp 
REM - IRMicrosoftAddin.Patch.5.7.18.1548.msp
REM - IRAdobePlugin.Patch.5.7.18.1548.msp
REM - imageright.desktop.exe.config - copied from the IRApplicationServer



REM ------------------------------------------------------
REM --------------- Install ImageRight Printer -----------
REM ------------------------------------------------------
ECHO ...... INSTALLING IMAGERIGHT PRINTER ......
start /w msiexec /qn /i "%InstallFiles%\IRDocCap.msi" /passive /log %windir%\Temp\IRDocCap.log ALLUSERS=true


REM ------------------------------------------------------
REM --------------- Install Document Converter -----------
REM ------------------------------------------------------
ECHO ...... INSTALL 32-BIT/64-BIT DOCUMENT CONVERTER ......

IF EXIST "%ProgramFiles% (x86)\ImageRight\Printer\PNSrv8.exe" (

start /w msiexec /qn /i "%InstallFiles%\IRDocumentConverter.64.msi" /passive /l*v %windir%\Temp\IRDocumentConverter.log ALLUSERS=true

) ELSE (

start /w msiexec /qn /i "%InstallFiles%\IRDocumentConverter.msi" /passive /l*v %windir%\Temp\IRDocumentConverter.log ALLUSERS=true
)


REM ------------------------------------------------------
REM --------------- Install ImageRight Desktop -----------
REM ------------------------------------------------------
ECHO ...... INSTALLING IMAGERIGHT Desktop ......
start /w msiexec /qn /i "%InstallFiles%\IRDesktop.msi" /passive /log %windir%\Temp\IRDesktop.log ALLUSERS=true


REM ------------------------------------------------------
REM --------------- Install Microsoft AddIn --------------
REM ------------------------------------------------------
REM UnREM the following 2 lines if used, MS Office 2010/2007

REM ECHO ...... INSTALLING MICROSOFT ADDIN ......
start /w msiexec /i "%InstallFiles%\IRMicrosoftAddin.msi" /passive /log %windir%\Temp\IRMicrosoftAddin.log ALLUSERS=true


REM ------------------------------------------------------
REM --------------- Install Adobe PlugIn -----------------
REM ------------------------------------------------------
REM UnREM the following 2 lines if used

REM ECHO ...... INSTALLING ADOBE PLUGIN ......
start /w msiexec /i "%InstallFiles%\IRAdobePlugin.msi" /passive /log %windir%\Temp\IRMicrosoftAddin.log ALLUSERS=true


REM ------------------------------------------------------
REM --------------- COPY WorkStation Patches ----------
REM ------------------------------------------------------

REMXCOPY "\\%InstallFiles%\IRDesktop.Patch.5.7.18.1548.msp" "C:\Program Files\ImageRight\Clients\" /I /y

REMXCOPY "\\%InstallFiles%\IRDesktop.Patch.5.7.18.1548.msp" "C:\Program Files\ImageRight\Clients\" /I /y

REMXCOPY "\\%InstallFiles%\IRDesktop.Patch.5.7.18.1548.msp" "C:\Program Files\ImageRight\Clients\" /I /y



REM ------------------------------------------------------
REM --------------- Install WorkStation Patches ----------
REM ------------------------------------------------------

REM ECHO ...... INSTALLING IMAGERIGHT Desktop Patch......
REM msiexec /qn /update "C:\Program Files\ImageRight\Clients\IRDesktop.Patch.5.7.18.1548.msp" /l*v %windir%\Temp\IRdesktoppatch.log

REM ECHO ...... INSTALLING IMAGERIGHT MSAddin Patch......
REM msiexec /qn /update "C:\Program Files\ImageRight\Clients\IRMicrosoftAddin.Patch.5.7.18.1548.msp" /l*v %windir%\Temp\IRdesktoppatch.log

REM ECHO ...... INSTALLING IMAGERIGHT Adobe Plugin Patch......
REM msiexec /qn /update "C:\Program Files\ImageRight\Clients\IRAdobePlugin.Patch.5.7.18.1548.msp" /l*v %windir%\Temp\IRdesktoppatch.log

REM ------------------------------------------------------
REM --------------- Copy Desktop Config File -------------
REM ------------------------------------------------------
REM --- This file should come from IRAppServer in --------
REM --- c:\program files (x86)\ImageRight\clients --------

ECHO ...... COPY IMAGERIGHT.DESKTOP.EXE.CONFIG ......

IF EXIST "%ProgramFiles% (x86)\ImageRight\Clients\imageright.desktop.exe" (

cd "%ProgramFiles% (x86)\ImageRight\Clients"

copy /Y /V "%InstallFiles%\imageright.desktop.exe.config"

) ELSE (

cd \%ProgramFiles%\ImageRight\Clients

REM copy /Y /V "%InstallFiles%\imageright.desktop.exe.config"

)
 


:END
EXIT
