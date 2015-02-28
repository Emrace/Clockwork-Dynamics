def caesar_encrypt(word, n):
	encrypted = ""
	letters = {}
	index = 0
	while index < 26:
		letters[chr(ord('a') + index)] = index
		index += 1
	
	for letter in word:
		if letter >= 'a' and letter <= 'z':
			current_letter = letters[letter] + n
			current_letter %= 26
			encrypted += chr(ord('a') + current_letter)
		elif letter >= 'A' and letter <= 'Z':
			letter = letter.lower()
			current_letter = letters[letter] + n
			current_letter %= 26
			encrypted += chr(ord('a') + current_letter).upper()
		else:
			encrypted += letter
	
	return encrypted
print caesar_encrypt("abc", 1)