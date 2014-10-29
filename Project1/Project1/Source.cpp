#include <iostream>
#include <ctime>
#include <cstdlib>
#include <stdio.h>
#include <string>
#include <algorithm>
#include <array>

using namespace std;

int main()
{

	//Add turn based two player mode

	int bulls = 0;
	int cows = 0;
	int temp_cow_count = 0;
	int max_digits = 4;
	string guess;
	string secret_number;
	string turn;
	
	srand((unsigned)time(NULL));

	int digit_pool [] = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

	random_shuffle(digit_pool, digit_pool + 10);

	for (int i = 0; i < max_digits; i++)
	{
		if (i == 0 && digit_pool[i] == 0)
		{
			secret_number += to_string(digit_pool[i + 4]);
			continue;
		}
		secret_number += to_string(digit_pool[i]);
	}

	//cout << secret_number << endl;

	cout << "This is a game of Bulls and Cows. Your goal is to guess the secret number." << endl;
	cout << "It consists of four different digits. If you get a digit and it's position \nright, you get a Bull. ";
	cout << "If you get only the digit, but not it's position, \nthen you get a Cow" << endl;
	cout << "Get 4 Bulls to win the game.\n" << endl;

	while (true)
	{
		cout << "Enter a number: " << endl;
		cin >> guess;		

		for (int i = 0; i < guess.length(); i++)
		{
			temp_cow_count = count(secret_number.begin(), secret_number.end(), guess[i]);

			if (secret_number[i] == guess[i])
			{
				 bulls++;
				cows--;
			}
			cows += temp_cow_count;
		}

		cout << "Cows: " << cows << endl << "Bulls: " << bulls << endl << endl;
						
		if (bulls == 4)
		{
			break;
		}

		bulls = 0;
		cows = 0;
	}

	if (bulls == 4)
	{
		cout << "You won!" << endl;
	}

	system("pause");
	return 0;
}