# Program Name: X's and O's Count
# Task Description: Take the string being passed and return the string true if there is an equal number of x's and o's. Otherwise return the string false.
# Parameter: Only these two letters will be entered in the string, no punctuation or numbers. 
# Example: If str is "xooxxxxooxo" then the output should return false because there are 6 x's and 5 o's.

def xo_count_check(str):

	count_x = 0
	count_o = 0
	
	count_x_o = str

	#check list for x's and o's
	for i in list(count_xo):
		if i == 'x':
			count_x += 1
		elif i == 'o':
			count_o += 1
		else:
			return
	
	print count_o
	print count_x
	
	if count_o == count_x:
		print 'true'
	else:
		print 'false'
		
user_txt = raw_input("input as many x's and o's as you'd like - x's and o's only: ")

xo_count_check(user_txt) 

#http://www.coderbyte.com/CodingArea/Editor.php?ct=Ex%20Oh&lan=Python