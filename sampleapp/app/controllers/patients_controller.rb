class PatientsController < ApplicationController
	skip_before_filter  :verify_authenticity_token
	
	def index
		 @patients= Patient.all
	end

	

	def new
		@patient = Patient.new
	end

	def create
		@patient = Patient.new(patient_params)
		if @patient.save        	
        	flash[:success] = "New record created"
        	#redirect_to salesreps_path(@site)
        	redirect_to action: 'index'
    	else
        	render 'new'
    	end
	end

	def edit
		@patient = Patient.find(params[:id])
	end

	def update
		@patient = Patient.find(params[:id])

		if @patient.update_attributes(patient_params)
			flash[:success] = "Record updated"
			redirect_to action: 'index'
		else
			render 'edit'
		end
	end

	def destroy
        Patient.find(params[:id]).destroy
        flash[:success] = 'Record deleted'
        redirect_to patients_url
    end


	private
    def patient_params
        params.require(:patient).permit(:id, :first_name, :last_name, :phone, :age)
    end

    #Confirms an admin user.
    def admin_user
        redirect_to(root_url) unless current_user.admin?
    end
end
