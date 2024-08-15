#include "calculadora.h"


float calculadora::sumar(float a, float b) const {
	return a + b;
}

float calculadora::restar(float a, float b) const {
	return a - b;
}

float calculadora::multiplicar(float a, float b) const {
	return a * b;
}

float calculadora::dividir(float a, float b) const {
	if (b == 0) {
		throw "Error, division by zero is not allowed";
	}
	return a / b;
}