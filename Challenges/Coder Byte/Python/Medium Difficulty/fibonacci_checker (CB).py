# Program Name: Fibonacci Checker
# Task Description: If num is in Fibonacci sequence, return the string yes if the number given is part of the Fibonacci sequence. If num is not in the Fibonacci sequence, return the string no.
# Parameter: N/A
# Example: The first two numbers are 0 and 1, then comes 1, 2, 3, 5 etc. 

def Fibonacci_Check(num):

	#Starting numbers of Fibonacci series
	list_nums = [0, 1]

	a = -1
	b = 0

	while list_nums[-1] <= num:

		a += 1
		b += 1
	
	#Fibonacci sequence produced
		sum = list_nums[a] + list_nums[b]
		list_nums.append(sum)
	
	print list_nums
	
	if num not in list_nums:
		print 'no'
	else:
		print 'yes'

user_num = int(raw_input("Check if what number is in Fibonacci series: "))

Fibonacci_Check(user_num)

#http://www.coderbyte.com/CodingArea/Editor.php?ct=Fibonacci%20Checker&lan=Python