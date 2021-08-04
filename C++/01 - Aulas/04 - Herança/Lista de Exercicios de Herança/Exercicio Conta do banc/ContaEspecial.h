#include "conta.h"

// classe filha
class ContaEspecial: public Conta{

private:
float limiteCar;

public:
	ContaEspecial();

void set_limiteCar(float num);
float get_limiteCar();



    void limiteCredito();


};

// CONSTRUCT
ContaEspecial::ContaEspecial(){
limiteCar    = 2500;

};



void ContaEspecial::set_limiteCar(float num){
	limiteCar = num;
}
float ContaEspecial::get_limiteCar(){
	return limiteCar;
}


void ContaEspecial::limiteCredito(){
    // LIMI VAI RECEBER O SALDO MAIS O LIMITE
    float limi = (get_saldo () + get_limiteCar());
    if (get_saldo()>0){
        if (limi >get_sacar()){
        set_saldo(get_saldo() - get_sacar());


        }else{
			cout<<"Voce não tem esse saldo\n";
			cout<<"Seu saldo e de: "<<limi<<"\n\n";
			system("pause");
		}
	}else{
		cout<<"Sua conta esta no negativo\n\n";
		system("pause");
	}
};

