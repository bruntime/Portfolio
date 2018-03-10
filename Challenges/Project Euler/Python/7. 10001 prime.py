#Project Euler

#Problem #7

# By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

# What is the 10001st prime number?

def is_prime(n):
	
	prime = []
	
	a = 0
	while a <= n:
		a += 1
		if n % a == 0:
		 prime.append(a)
	if len(prime) > 2:
		return False
	else:
		return True
		
count = []
x = 1

while len(count) < 10001:
	x += 1
	if is_prime(x):
		count = count + [x]
		print count[-1]