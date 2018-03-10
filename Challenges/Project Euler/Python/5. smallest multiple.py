#Project Euler

#Problem #5

#2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
#What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

for x in xrange (1,  999999):
	for num in range(2, 21):
		if x % all(num) == 0:
			print x

