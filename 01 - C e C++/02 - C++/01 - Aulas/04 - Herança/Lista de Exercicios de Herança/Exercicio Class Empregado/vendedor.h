#include "empregado.h"
class Vendedor: public Empregado{

	private:
	float salario;
	float valorVenda;
	float comissao;
	public:
    Vendedor());
    public:
    void set_salario(float num);
	void set_valorVenda(float num);
	void set_comissao(float num);

   float get_salario();
   float get_valorVenda();
   float get_comissao();



	void exibir();
	void valorSalario();


};

Vendedor::Vendedor(){
salario     = 2000;
valorVenda  = 4000;
comissao    = 258;
};
void Vendedor::set_salario(float num){
	salario = num;
};
void Vendedor::set_valorVenda(float num){
	valorVenda = num;
};
void Vendedor::set_comissao(float num){
	comissao = num;
};

// PARTE DO GET
float Vendedor::get_salario(){
	return salario;
};
float Vendedor::get_valorVenda(){
	return valorVenda;
};
float Vendedor::get_comissao(){
    return comissao;
};

void Vendedor::valorSalario(){
    int vl;
    vl = (get_salario() + get_valorVenda() * get_comissao())
    return vl;
};





