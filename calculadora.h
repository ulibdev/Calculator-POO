#ifndef CALCULADORA_H
#define CALCULADORA_H


class calculadora
{
public:
	calculadora() = default;

	float sumar(float a, float b) const;

	float restar(float a, float b) const;

	float multiplicar(float a, float b) const;

	float dividir(float a, float b) const;

};

#endif
