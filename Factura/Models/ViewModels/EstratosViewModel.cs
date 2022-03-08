namespace Factura.Models.ViewModels
{
    public class EstratosViewModel
    {
        public int Estrato { get; set; }
        public string Sector { get; set; }
        public decimal Subsidio { get; set; }
        public decimal Contribucion { get; set; }

        #region Acueducto
        public decimal Acu_CargoFijo { get; set; }
        public decimal Acu_ConsumoBasico { get; set; }
        public decimal Acu_ConsumoComplementario { get; set; }
        public decimal Acu_ConsumoSuntuario { get; set; }
        public decimal TarifaxConsumoAgua { get; set; }
        public decimal TotalCargoFijoAcueducto { get; set; }
        public decimal SubTotalAgua { get; set; }
        #endregion

        #region Alcantarilado
        public decimal Alc_CargoFijo { get; set; }
        public decimal Alc_VertimientoBasico { get; set; }
        public decimal Alc_VertimientoComplementario { get; set; }
        public decimal Alc_VertimientoSuntuario { get; set; }
        public decimal TotalCargoFijoAlcantarillado { get; set; }
        public decimal SubTotalAlcantarillado { get; set; }
        public decimal TarifaCOnsumoAlcantarillado { get; set; }
        #endregion
        public decimal TarifaAseo { get; set; }
        public decimal TotalaPagar { get; set; }

        public void DefinirTarifas(int estrato)
        {
            this.Estrato = estrato;

            switch (estrato)
            {
                case 1:
                    this.Sector = "Bajo - Bajo";
                    this.Subsidio = 0.7M;
                    this.Acu_CargoFijo = 2872.35M;
                    this.Acu_ConsumoBasico = 462.24M;
                    this.Acu_ConsumoComplementario = 1500.78M;
                    this.Acu_ConsumoSuntuario = 1500.78M;

                    this.Alc_CargoFijo = 1490.51M;
                    this.Alc_VertimientoBasico = 418.35M;
                    this.Alc_VertimientoComplementario = 1358.29M;
                    this.Alc_VertimientoSuntuario = 1358.29M;

                    this.TarifaAseo = 4050.45M;
                    break;
                case 2:
                    this.Sector = "Bajo";
                    this.Subsidio = 0.4M;
                    this.Acu_CargoFijo = 5744.70M;
                    this.Acu_ConsumoBasico = 924.28M;
                    this.Acu_ConsumoComplementario = 1500.78M;
                    this.Acu_ConsumoSuntuario = 1500.78M;


                    this.Alc_CargoFijo = 2981.03M;
                    this.Alc_VertimientoBasico = 836.71M;
                    this.Alc_VertimientoComplementario = 1358.29M;
                    this.Alc_VertimientoSuntuario = 1358.29M;

                    this.TarifaAseo = 8437.67M;
                    break;

                  
                case 3:
                    this.Sector = "Medio - Bajo";
                    this.Subsidio = 0.15M;
                    this.Acu_CargoFijo = 8141.43M;
                    this.Acu_ConsumoBasico = 1310.18M;
                    this.Acu_ConsumoComplementario = 1500.78M;
                    this.Acu_ConsumoSuntuario = 1500.78M;


                    this.Alc_CargoFijo = 4224.74M;
                    this.Alc_VertimientoBasico = 1185.79M;
                    this.Alc_VertimientoComplementario = 1358.29M;
                    this.Alc_VertimientoSuntuario = 1358.29M;

                    this.TarifaAseo = 12225.99M;


                    break;

                case 4:
                    this.Sector = "Medio";
                    this.Subsidio = 0M;
                    this.Acu_CargoFijo = 9325.81M;
                    this.Acu_ConsumoBasico = 1500.78M;
                    this.Acu_ConsumoComplementario = 1500.78M;
                    this.Acu_ConsumoSuntuario = 1500.78M;

                    this.Alc_CargoFijo = 4839.33M;
                    this.Alc_VertimientoBasico = 1358.29M;
                    this.Alc_VertimientoComplementario = 1358.29M;
                    this.Alc_VertimientoSuntuario = 1358.29M;

                    this.TarifaAseo = 15185.36M;
                    break;

                case 5:
                    this.Sector = "Medio - Alto";
                    this.Contribucion = 0.5M;
                    this.Acu_CargoFijo = 14800.05M;
                    this.Acu_ConsumoBasico = 2381.73M;
                    this.Acu_ConsumoComplementario = 2381.73M;
                    this.Acu_ConsumoSuntuario = 2381.73M;

                    this.Alc_CargoFijo = 7680.02M;
                    this.Alc_VertimientoBasico = 2155.60M;
                    this.Alc_VertimientoComplementario = 2155.60M;
                    this.Alc_VertimientoSuntuario = 2155.60M;

                    this.TarifaAseo = 25424.12M;

                    break;
                case 6:
                    this.Sector = "Alto";
                    this.Contribucion = 0.6M;
                    this.Acu_CargoFijo = 15788.59M;
                    this.Acu_ConsumoBasico = 2540.81M;
                    this.Acu_ConsumoComplementario = 2540.81M;
                    this.Acu_ConsumoSuntuario = 2540.81M;

                    this.Alc_CargoFijo = 8192.99M;
                    this.Alc_VertimientoBasico = 2299.58M;
                    this.Alc_VertimientoComplementario = 2299.58M;
                    this.Alc_VertimientoSuntuario = 2299.58M;

                    this.TarifaAseo = 30711.30M;
                    break;
            }

        }

        public void ConsumoTotal(int consumo)
        {
            var BASICO = 16;
            var COMPLEMENTARIO = 32;


            if (consumo <= BASICO)
            {
                switch(this.Estrato)
                {
                    case 1:
                    case 2:
                    case 3:
                        if (consumo <= 20)
                        {
                            // Acueducto subtotal
                            this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoBasico) - this.Subsidio;
                            this.TotalCargoFijoAcueducto = this.Acu_CargoFijo - this.Subsidio;
                            this.SubTotalAgua = this.TarifaxConsumoAgua + TotalCargoFijoAcueducto;

                            // Alcantarillado subtotal
                            this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico) - this.Subsidio;
                            this.TotalCargoFijoAlcantarillado = this.Alc_CargoFijo - this.Subsidio;
                            this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + TotalCargoFijoAlcantarillado;

                            this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;


                        }
                        else
                        {
                            this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoBasico);
                            this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;

                            this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                            this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;

                            this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;


                        }
                        break;

                    case 4:
                        this.TarifaxConsumoAgua = consumo * this.Acu_ConsumoBasico;
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;


                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;

                        this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;

                    case 5:
                    case 6:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoBasico) + this.Contribucion;
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;


                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico) + this.Contribucion;
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo; ;

                        this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;
                }
            }

            if (consumo > BASICO & consumo <= COMPLEMENTARIO)
            {
                switch (this.Estrato)
                {
                    case 1:
                    case 2:
                    case 3:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoBasico);
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;

                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;
                        
                            this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;

                    case 4:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoBasico);
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;

                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;
                        
                        this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;

                    case 5:
                    case 6:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoComplementario) + this.Contribucion;
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;

                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;
                        
                        
                       this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;


                }
            }

             if (consumo > COMPLEMENTARIO)
            {
                switch (this.Estrato)
                {
                    case 1:
                    case 2:
                    case 3:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoSuntuario);
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;

                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;



                        this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;

                    case 4:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoSuntuario);
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;


                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico);
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;


                        this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;
                    case 5:
                    case 6:
                        this.TarifaxConsumoAgua = (consumo * this.Acu_ConsumoSuntuario) + this.Contribucion;
                        this.SubTotalAgua = this.TarifaxConsumoAgua + this.Acu_CargoFijo;

                        this.TarifaCOnsumoAlcantarillado = (consumo * this.Alc_VertimientoBasico) + this.Contribucion;
                        this.SubTotalAlcantarillado = this.TarifaCOnsumoAlcantarillado + this.Alc_CargoFijo;


                        this.TotalaPagar = this.SubTotalAgua + this.SubTotalAlcantarillado + this.TarifaAseo;

                        break;
                }
            }
        }
    }
}
