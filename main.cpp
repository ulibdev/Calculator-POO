#include <iostream>
#include "calculadora.h"

using namespace std;

int main() {
	calculadora casio;

	cout <<"Suma:" << casio.sumar(10, 10) << endl;

	cout << "Resta:" << casio.restar(10, 10) << endl;

	cout << "Multiplicacion:" << casio.multiplicar(10, 10) << endl;

	cout << "Division:" << casio.dividir(10, 10) << endl;

	return 0;
}