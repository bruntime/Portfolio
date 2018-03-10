# Program Name: Array Addition
# Task Description: Take array of numbers and return the string true if any combination of numbers in the array can be added up to equal the largest number in the array, otherwise return the string false.
# Parameter: The array will not be empty, will not contain all the same elements, and may contain negative numbers.
# Example: If arr contains [4, 6, 23, 10, 1, 3] the output should return true because 4 + 6 + 10 + 3 = 23. 

from itertools import chain, combinations

def addition(arr):

	numbers = arr
	numbers.sort()
	print "Sorted Numbers: ", numbers
		
	a = -1
	b = 0

	#check if elements are the same - print error message	
	while numbers[b] != numbers[-1]:
		a += 1
		b += 1
		if numbers[a] == numbers[b]:
			print "There are duplicates in this list"
			break
	
	#TO WORK ON: check combination of numbers added to equal largest number
	
	combos = list(chain(*(combinations(numbers, i) for i in range(1, 1 + len(numbers)))))

	combos_values = combos[len(numbers):]
	
	sum_combos = []
	
	print "Combinations:", combos_values
	
	for x in combos_values:
		sum_combos = sum_combos + [sum(x)]
	
	print "Sum of Combinations", sum_combos
	
	if numbers[-1] in sum_combos:
		print "true"
	else:
		print "false"
		
#automatically checks to see if list is empty	
user_txt = list(input("Numbers: "))	
addition(user_txt)