#include "empregado.h"
class Gerente: public Empregado{

	private:
	float salarioMensal;

	public:
    Vendedor());
    public:
    void set_salarioMensal(float num);
    float get_salarioMensal();

	void valorSalario();


};

Vendedor::Vendedor(){
salarioMensal     = 1300;

};
void Vendedor::set_salarioMensal(float num){
	salarioMensal = num;
};

float Vendedor::get_salarioMensal(){
	return salarioMensal;
};


void Vendedor::valorSalario(){
    cout<<"Salario Mensal:"<<get_salarioMensal();
};
