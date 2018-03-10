# Program Name: Number Search
# Task Description:  Search for all the numbers in the string, add them together, then return that final number divided by the total amount of letters in the string. 
# Parameter: Only single digit numbers separated by spaces will be used throughout the whole string (So this won't ever be the case: hello44444 world). Each string will also have at least one letter.
# Example: "Hello6 9World 2, Nic8e D7ay!" the output should be 2. First if you add up all the numbers, 6 + 9 + 2 + 8 + 7 you get 32. Then there are 17 letters in the string. 32 / 17 = 1.882, and the final answer should be rounded to the nearest whole number, so the answer is 2.

def NumberSearch(str): 

  	str = "".join(c for c in str if c not in ('!','.',':', '?', '"', '(', ')', '^', '&', '?', '`', '~', ' ', ','))
	
	characters = list(str)
	letters = list(c for c in str if c not in ('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'))
	
	print characters
	print letters
	
	numbers_from_txt = []
	
	char_total = len(letters)
	
	for x in characters:
		if x == '1' or x == '2' or x == '3'or x == '4' or x == '5' or x == '6' or x == '7' or x == '8' or x == '9' or x == '0':
			numbers_from_txt.append(int(x))
	
	totalsum = sum(numbers_from_txt)
	
	print int(round(float(totalsum)/float(char_total)))
    
user_txt = raw_input('sentence: ')

NumberSearch(user_txt)

#http://coderbyte.com/CodingArea/GuestEditor.php?ct=Number%20Search&lan=Python