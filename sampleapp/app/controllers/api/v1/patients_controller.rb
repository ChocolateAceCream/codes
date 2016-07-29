class Api::V1::PatientsController < ApplicationController
  skip_before_filter  :verify_authenticity_token
  def index
  	@patient = Patient.all
    @reply =[]
    @patient.each do |patient|
      
      @reply<< [patient.id, patient.last_name, patient.first_name, patient.phone, patient.age]
    end
    respond_to do |format|
        format.json { render :json => @reply}
    end
  end

  def show
    @patient = Patient.find(params[:id])
      respond_to do |format|
        format.json { render :json => [@patient.id,@patient.last_name, @patient.first_name, @patient.phone, @patient.age]}
      end
  end

  def create
    @patient = Patient.new(patient_params)
    respond_to do |format|
      if @patient.save
        format.json { render json: @patient, status: :created }
        format.xml { render xml: @patient, status: :created }
      else
        format.json { render json: @patient.errors, status: :unprocessable_entity }
        format.xml { render xml: @patient.errors, status: :unprocessable_entity }
      end
    end
  end

  def update
    respond_to do |format|
      if @patient.update_attributes(params[:patient])
        format.json { head :no_content, status: :ok }
        format.xml { head :no_content, status: :ok }
      else
        format.json { render json: @patient.errors, status: :unprocessable_entity }
        format.xml { render xml: @patient.errors, status: :unprocessable_entity }
      end
    end
  end

  def destroy
    @patient = Patient.find(patient_params)
    @patient.destroy

    respond_to do |format|
      if @patient.destroy
        format.json { head :no_content, status: :ok }
        format.xml { head :no_content, status: :ok }
      else
        format.json { render json: @patient.errors, status: :unprocessable_entity }
        format.xml { render xml: @patient.errors, status: :unprocessable_entity }
      end
    end
  end

  private

  def patient_params
    params.require(:patient).permit(:id, :last_name, :first_name, :phone, :age)
  end

end


