import { NetCoreTemplatePage } from './app.po';

describe('NetCore App', function() {
  let page: NetCoreTemplatePage;

  beforeEach(() => {
    page = new NetCoreTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
