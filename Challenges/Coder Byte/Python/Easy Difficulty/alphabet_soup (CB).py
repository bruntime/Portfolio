# Program Name: Alphabetize Characters
# Task Description: Return a string with the letters in alphabetical order.
# Parameter: Numbers and punctuation symbols will not be included in the string.
# Example: hello becomes ehllo

def string_alphabetical_order(word):

	#ignore punctuation symbols and numbers
	word = "".join(c for c in word if c not in ('!','.',':', '?', '"', '(', ')', '^', '&', '?', '`', '~', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'))
	
	chars = list(word)
	chars.sort() #sorted characters in a list
	
	characters = []
	
	#rejoin characters as string
	characters = "".join(x for x in chars)
	print characters
		
one_word = raw_input("Write word here: ")

string_alphabetical_order(one_word)

#http://www.coderbyte.com/CodingArea/Editor.php?ct=Alphabet%20Soup&lan=Python