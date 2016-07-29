class Api::V1::SitesController < ApplicationController
  def index
  	@site = Site.all
    @reply =[]
    @site.each do |site|
      
      @reply<< [site.id, site.ip, site.name,site.description, site.updated_at, site.ping]
    end
    respond_to do |format|
        format.json { render :json => @reply}
    end
  end


  def show
    @site = Site.find(params[:id])
	    respond_to do |format|
	      format.json { render :json => [@site.id,@site.name]}
	    end
  end

end