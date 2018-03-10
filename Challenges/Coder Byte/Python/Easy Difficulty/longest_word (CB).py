# Program Name: Longest Word Returned
# Task Description: Return the largest word in a string. If there are two or more words that are the same length, return the first word from the string with that length. 
# Parameter: Ignore punctuation and assume sen will not be empty.
# Example: N/A
 
import string

def LongestWord(sen):

#1. remove punctuation marks
	for x in string.punctuation:
		sen = sen.replace(x, "")

#2. place user text in list and separate text into words	
	sentence = sen.split(" ")

#3. keep version of list
	oldsentence = sentence

#4. compare length of each word

	while len(sentence) != 1: #loops until only 1 word left
		if len(sentence[0]) >= len(sentence[1]):
			sentence.remove(sentence[1])
		elif len(sentence[0]) < len(sentence[1]):
			sentence.remove(sentence[0])

	for x in sentence:		
		print "Longest word in sentence:", x

print "\nProgram to Determine Longest Word in Sentence\n"
 
user_text = raw_input("Write sentence here: ")

LongestWord(user_text)

#http://coderbyte.com/CodingArea/Editor.php?ct=Longest%20Word&lan=Python