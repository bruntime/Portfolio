# Convert number to time
# Example: if num = 63 then the output should be 1:3
# Separate the number of hours and minutes with a colon

def TimeConvert(num):

	time = num/60
	extra_minutes = num - (time * 60)
	
	colon = ":"
	zeros = ":00"
	if extra_minutes > 0:
		print "%d%s%d" %(time, colon, extra_minutes)
	else:
		print "%d%s" %(time, zeros)

user_time = int(raw_input("Number: "))
	
TimeConvert(user_time)