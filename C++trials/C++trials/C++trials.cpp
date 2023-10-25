// C++trials.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

class Data
{

	int dzien;
	int miesiac;
	int rok;

public:

	int getDzien() { return dzien; }
	int getMiesiac() { return miesiac; }
	int getRok() { return rok; }
	int set(int, int, int);

};

int Data::set(int d, int m, int r) //definicja metody { //poza klasa
{
	if (d < 1 || d>31) return 1; 
	if (m < 1 || m>12) return 2; 
	if (r < 1970) return 3; 
	dzien = d;
	miesiac = m; 
	rok = r; 
	return 0;
}
int main() {
	Data data;
	int d, m, r;
	do
	{
		cout << "Wprowadz dzien miesiac oraz rok" << endl;
		cin >> d >> m >> r;
	} while (data.set(d, m, r));
	cout << "Wprowadzona data:" << endl;
	cout << data.getDzien() << " " << data.getMiesiac() << " ";
	cout << data.getRok() << endl;
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
