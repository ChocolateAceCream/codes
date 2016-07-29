
# List all users in that have not logged on within  
# XXX days in "Active Directory"  
#   
# Get the Current Date  
$COMPAREDATE=get-date 

# Number of Days to check back.     
$NumberDays=45  
#  
# Organizational Unit to search  
$OU='example.com' 
# It can be limited to certain OUs if for some reason you need to limit it that way 
# $OU='example.com/North Pole' 
# -SizeLimit   Maximum number of items to be returned (default=1000) 
GET-QADUSER -SizeLimit 100 -SearchRoot $OU |  
#where { $_.LastLogonTimeStamp.AddDays($NumberDays) -gt $CURRENTDATE } | 
where { $_.lastlogontimestamp -le (get-date).adddays(-$NumberDays) } |  
Where {$_.ParentContainer -notmatch "$OU/Service Accounts"} |  
DISABLE-QADUSER | 
select Name, ParentContainer, Department, Office, Description, LastLogonTimeStamp, LastLogon, AccountIsDisabled | 
Export-Csv Users_Not_Logged_in_past_45_days_$date.csv -noTypeInformation 
#  
# Add in a | DISABLE-QADUSER to AUTOMATICALLY Disable those accounts.  
# Line should read like this if you want to do that  
# GET-QADUSER -SearchRoot $OU | where { $_.lastlogontimestamp -le (get-date).adddays(-$NumberDays) } | DISABLE-QADUSER
