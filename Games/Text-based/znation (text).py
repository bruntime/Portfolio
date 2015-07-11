#Project: Text-based game based on SyFy's Z Nation TV show

import sys
from zgame_functions import intro

def endgame():
	print "Thank you for playing."
	retry = raw_input("Would you like to try again? Y or N? ")
	if retry in {'y', 'Y'}:
		first_choice()
	if retry in {'n', 'N'}:
		return

def first_choice():
	print "What do you want to do?"
	first_action = raw_input("Do you want to (1) shoot a few of the zombies behind the gate or (2) run to find the doctor ")
	if first_action == '1':
		print '''
		You've made the zombies VERY angry. 
		You've alerted several down the hall.
		One zombie comes from behind you and bites your neck.
		Another grabs you by your legs.
		You're a goner.
		'''
		endgame()
	if first_action == '2':
		print '''
		You run down the hall. The gate is creaking. 
		You think "I hope Valdez can hold them off."
		'''
		left_right()
		
def left_right():
	print '''
		Your radio goes off. 
		Radio: This is Delta-X-ray-Delta at Camp Northern Light
		You're to escort Doctor Merch to a new destination.
		The CDC Mass Infection Lab on Mount Wilson.
		It's Priority Level 1.
		You: Get us out of here now!!!! This gate won't hold them.
	'''
	choice = raw_input("You've come to a dead end. You can only go left or right. Which way? ")
	if choice in {'left', 'Left'}:
		print '''
		You run a few minutes before realising that there's nothing here.
		You turn back to find the hallway is filling up with zombies.
		You start firing killing a few of them but there are too many.
		You're running out of ammo so you start hitting them with the end of your rifle.
		Maybe you can still make it to the doctor but you realise that one of the dead bodies on the ground is Valdez.
		You pause, long enough to get attacked by the zombies.
		You're a goner.
		'''
		endgame()
		
	if choice in {'right', 'Right'}:
		print '''
		Running down the hall you find the doctor.
		You grab her and take her to the roof where the helicopter is waiting.
		You[yelling]: Hey Doc. If I'm not back in two minutes, tell them to leave without me.
		'''

print intro()
first_choice()