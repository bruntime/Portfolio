#Project Euler

#Problem #500

#The number of divisors of 120 is 16. In fact 120 is the smallest number having 16 divisors.

#Find the smallest number with 2^500500 divisors. Give your answer modulo 500500507.

divisors = []

a = -1

while len(divisors) < 20:
	a += 1
	for x in range(1+a, 100):  
		for y in range(1,(x/2)): #define range of numbers to divide x by
			if x % y == 0:
				divisors = divisors + [x] #append the new numbers to the list
				if len(divisors) != 19:
					divisors[:] #erase contents of list
					continue
			else:
				print divisors
				print len(divisors)
				break
					