# Program Name: Minimum Consecutive Count
# Task Description: Take an array of integers and return the minimum number of integers needed to make the contents consecutive from the lowest number to the highest number. 
 # Parameter: Negative numbers may be entered and no array will have less than 2 elements.
 # Example: For [4, 8, 6] the output should be 2 because two numbers need to be added to the array (5 and 7) to make it from 4 to 8. 
 
def consecutive(arr):
 
	nums = arr
	missing_nums = []

#3. get all consecutive numbers from first index in list to last index in list
	for j in range(nums[0], nums[-1]+1):
		missing_nums = missing_nums +[j]

#4. define 2 groups - group 1: initial list of numbers, group 2: all numbers	
	group1 = set(nums)
	group2 = set(missing_nums)
	 
	print group1, "\n", group2

#5. compare both groups of numbers
	missing = group2.difference(group1)

#6. determine minimum number of integers needed for consecutive state
	print "Total numbers needed to make list consecutive: ", len(missing)

#1. take given numbers from user	
user_nums = raw_input("Give a list of numbers: ")
numbers = map(int, user_nums.split(',')) #place numbers in list then sort
numbers.sort()

#2. pass list through function
consecutive(numbers)

#http://www.coderbyte.com/CodingArea/Editor.php?ct=Consecutive&lan=Python