#Project Euler

#Problem #3

#The prime factors of 13195 are 5, 7, 13 and 29.
#What is the largest prime factor of the number 600851475143?

def is_prime(n):
	
	prime = []
	
	a = 0
	while a <= n:
		a += 1
		if n % a == 0:
		 prime = prime + [a]
	if len(prime) > 2:
		return False
	else:
		return True

a = 1
check_num = 279
factors = []

while a <= (check_num/2):
	a +=1
	if check_num % a == 0:
		if is_prime(a):
			factors = factors + [a]
print factors[-1]