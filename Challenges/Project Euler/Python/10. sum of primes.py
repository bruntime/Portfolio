#Project Euler

#Problem #10 Summation of Primes

#The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
#Find the sum of all the primes below two million.

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

list_num1 = []	
list_num2 = []
list_num3 = []
list_num4 = []
list_num5 = []
list_num6 = []
list_num7 = []
list_num8 = []
list_num9 = []
list_num10 = []
list_num11 = []

for num in xrange (1, 200000):
	if is_prime(num):
		list_num1 = list_num1 + [num]

for num in xrange (200000, 400000):
	if is_prime(num):
		list_num2 = list_num2 + [num]
		
for num in xrange (400000, 600000):
	if is_prime(num):
		list_num3 = list_num3 + [num]

for num in xrange (600000, 800000):
	if is_prime(num):
		list_num4 = list_num4 + [num]

for num in xrange (800000, 1000000):
	if is_prime(num):
		list_num5 = list_num5 + [num]

for num in xrange (1000000, 1200000):
	if is_prime(num):
		list_num6 = list_num6 + [num]

for num in xrange (1200000, 1400000):
	if is_prime(num):
		list_num7 = list_num7 + [num]

for num in xrange (1200000, 1400000):
	if is_prime(num):
		list_num8 = list_num8 + [num]

for num in xrange (1400000, 1600000):
	if is_prime(num):
		list_num9 = list_num9 + [num]

for num in xrange (1600000, 1800000):
	if is_prime(num):
		list_num10 = list_num10 + [num]

for num in xrange (1800000, 2000000):
	if is_prime(num):
		list_num11 = list_num11 + [num]

print sum(list_num1 + list_num2 + list_num3 + list_num4 + list_num5 + list_num6 + list_num7 + list_num8 + list_num9 + list_num10 + list_num11)