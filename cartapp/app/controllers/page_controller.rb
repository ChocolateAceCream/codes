class PageController < ApplicationController
  before_action :authenticate_user!, only: [:about, :faqs]
  def home
  end

  def about
  end

  def faqs
  end

  def contact
  end
end
