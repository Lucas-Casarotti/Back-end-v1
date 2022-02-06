#include "empregado.h"
class Horista: public Empregado{

	private:
	int horasTrab;
	int valorHora;
	public:
    Horista());
    public:
    void set_horasTrab(int num);
	void set_valorHora(int num);


    int get_horasTrab();
    int get_valorHora();

};

Horista::Horista(){
horasTrab    = 8;
valorHora    = 100;

};
void Horista::set_horasTrab(int num){
	horasTrab = num;
};
void Horista::set_valorHora(int num){
	valorHora = num;
};

// PARTE DO GET
float Horista::get_horasTrab(){
	return horasTrab;
};
float Horista::get_valorHora(){
	return valorHora;
};

void Empregado::valorSalario(){
cout<<"O valor do seu salario:"<<v1;

};



