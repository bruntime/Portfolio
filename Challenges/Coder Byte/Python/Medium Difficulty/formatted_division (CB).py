# Program Name: Formatted Quotient
# Task Description: Take 2 numbers and divide one with the other. Return the result as a string with properly formatted commas and 4 significant digits after the decimal place. 
# Parameter: The output must contain a number in the one's place even if it is a zero.
# Example: If num1 is 123456789 and num2 is 10000 the output should be "12,345.6789". 

import string

def format_result(num1, num2):

	#format: 8 places before the decimal point, 4 decimal places after
	print("{:8,.4f}".format(float(num1)/float(num2)))

user_num1 = int(raw_input("Number 1: ")) 
user_num2 = int(raw_input("Number 2: "))

format_result(user_num1, user_num2)

#http://www.coderbyte.com/CodingArea/Editor.php?ct=Formatted%20Division&lan=Python