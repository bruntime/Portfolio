# Program Name: Capitalize First Letter
# Task Description: Take the string being passed and capitalize the first letter of each word.
# Parameter: Words will be separated by only one space.
# Example: 'great value brand' becomes 'Great Value Brand'.

# LetterCapitalize(str) take the str parameter 

def letter_capitalize(str):

	#Divide string into separate words, place in list
	sentence = str.split(" ")
	
	#Capitalize each word in list
	sentence = [x.capitalize() for x in sentence]
	
	#Rejoin words into a sentence
	new_sentence = " ".join(sentence)
	
	print new_sentence

user_txt = raw_input("Sentence here: ")

letter_capitalize(user_txt)

#http://www.coderbyte.com/CodingArea/Editor.php?ct=Letter%20Capitalize&lan=Python